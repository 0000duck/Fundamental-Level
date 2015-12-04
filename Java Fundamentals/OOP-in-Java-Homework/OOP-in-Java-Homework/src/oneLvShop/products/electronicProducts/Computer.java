package oneLvShop.products.electronicProducts;

import oneLvShop.products.AgeRestriction;

import java.math.BigDecimal;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public class Computer extends ElectronicProducts {
    private final int quantityForPriceDiscount = 1000;

    private static final BigDecimal discount = new BigDecimal("0.95");

    public Computer(String name, BigDecimal price, double quantity) {
        super(name, price, quantity, AgeRestriction.Adult, 24);
    }

    @Override
    public BigDecimal getPrice() {
        if (super.getQuantity() > quantityForPriceDiscount) {
            return super.getPrice()
                    .multiply(discount);
        }
        return super.getPrice();
    }
}
