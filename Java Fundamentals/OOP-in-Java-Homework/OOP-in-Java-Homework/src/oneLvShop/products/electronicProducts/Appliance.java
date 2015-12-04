package oneLvShop.products.electronicProducts;

import oneLvShop.products.AgeRestriction;

import java.math.BigDecimal;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public class Appliance extends ElectronicProducts {
    private final int quantityForPriceAdditon = 50;

    private static final BigDecimal addition = new BigDecimal("1.05");

    public Appliance(String name, BigDecimal price, double quantity) {
        super(name, price, quantity, AgeRestriction.Adult, 6);
    }

    @Override
    public BigDecimal getPrice() {
        if (super.getQuantity() < quantityForPriceAdditon) {
            return super.getPrice()
                    .multiply(addition);
        }
        return super.getPrice();
    }
}
