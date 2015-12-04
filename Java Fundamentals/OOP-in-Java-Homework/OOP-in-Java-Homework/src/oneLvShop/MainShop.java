package oneLvShop;

import oneLvShop.interfaces.Expirable;
import oneLvShop.products.AgeRestriction;
import oneLvShop.products.FoodProduct;
import oneLvShop.products.Product;
import oneLvShop.products.electronicProducts.Appliance;
import oneLvShop.products.electronicProducts.Computer;

import java.math.BigDecimal;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Comparator;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public class MainShop {
    public static void main(String[] args) {
        FoodProduct cigars = new FoodProduct(
                "420 Blaze it fgt",
                new BigDecimal(6.90),
                1400,
                AgeRestriction.Adult,
                LocalDate.now()
                        .plusMonths(3));
        Customer pecata = new Customer("Pecata", 17, new BigDecimal(30.00));
        try {
            PurchaseManager.processPurchase(pecata, cigars);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }

        Customer gopeto = new Customer("Gopeto", 18, new BigDecimal(0.44));
        try {
            PurchaseManager.processPurchase(gopeto, cigars);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        System.out.println();

        ArrayList<Product> products = new ArrayList<>();
        products.add(cigars);
        Computer computer = new Computer("HomePC", new BigDecimal(1000), 15);
        products.add(computer);
        Computer laptop = new Computer("Laptop", new BigDecimal(1500), 12);
        products.add(laptop);
        Appliance dishWasher = new Appliance("DishWasher", new BigDecimal(500), 10);
        products.add(dishWasher);
        FoodProduct bread = new FoodProduct(
                "Franzela",
                new BigDecimal(0.80),
                50,
                AgeRestriction.None,
                LocalDate.now().plusDays(1));
        products.add(bread);
        Appliance kitchenKnife = new Appliance("Knife", new BigDecimal(50), 200);
        products.add(kitchenKnife);

        String name = products.stream()
                .filter(p -> p instanceof Expirable)
                .map(p -> ((FoodProduct) p))
                .sorted(Comparator.comparing(p -> p.getExpirationDate()))
                .findFirst()
                .get()
                .getName();
        System.out.println(name);

        System.out.println();
        products.stream()
                .filter(p -> p.getAgeRestriction() == AgeRestriction.Adult)
                .sorted(Comparator.comparing(p -> p.getName()))
                .forEach(p -> System.out.println(p.getName()));
    }
}
