package oneLvShop;

import oneLvShop.exceptions.BuyerDoesNotHaveEnoughMoneyException;
import oneLvShop.exceptions.CustomerTooYoungException;
import oneLvShop.exceptions.ProductHasExpiredException;
import oneLvShop.exceptions.ProductOutOfStockException;
import oneLvShop.products.AgeRestriction;
import oneLvShop.products.FoodProduct;
import oneLvShop.products.Product;

import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public final class PurchaseManager {
    private static final int minAdultAge = 18;

    private PurchaseManager() {
    }

    public static void processPurchase(Customer customer, Product product) throws ProductHasExpiredException,
            ProductOutOfStockException,
            BuyerDoesNotHaveEnoughMoneyException,
            CustomerTooYoungException {
        if (product instanceof FoodProduct) {
            long daysBetween = ChronoUnit.DAYS.between(LocalDate.now(), ((FoodProduct) product).getExpirationDate());
            if (daysBetween <= 0) {
                throw new ProductHasExpiredException();
            }
        }
        if (product.getQuantity() < 1) {
            throw new ProductOutOfStockException();
        }
        if (customer.getBalance()
                .compareTo(product.getPrice()) == -1) {
            throw new BuyerDoesNotHaveEnoughMoneyException();
        }
        if (product.getAgeRestriction() == AgeRestriction.Adult &&
                customer.getAge() < minAdultAge) {
            throw new CustomerTooYoungException();
        }
        customer.setBalance(customer.getBalance()
                .subtract(product.getPrice()));
        product.setQuantity(product.getQuantity() - 1);
    }
}
