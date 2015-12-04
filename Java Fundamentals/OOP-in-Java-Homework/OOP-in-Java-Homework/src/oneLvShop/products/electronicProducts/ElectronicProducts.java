package oneLvShop.products.electronicProducts;

import oneLvShop.products.AgeRestriction;
import oneLvShop.products.Product;

import java.math.BigDecimal;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public class ElectronicProducts extends Product {
    private int guaranteePeriod;

    public ElectronicProducts(String name, BigDecimal price, double quantity, AgeRestriction ageRestriction, int guaranteePeriod) {
        super(name, price, quantity, ageRestriction);
        this.setGuaranteePeriod(guaranteePeriod);
    }

    public int getGuaranteePeriod() {
        return guaranteePeriod;
    }

    public void setGuaranteePeriod(int guaranteePeriod) {
        if (guaranteePeriod < 0) {
            throw new IllegalArgumentException("Guarantee period cannot be negative.");
        }
        this.guaranteePeriod = guaranteePeriod;
    }
}
