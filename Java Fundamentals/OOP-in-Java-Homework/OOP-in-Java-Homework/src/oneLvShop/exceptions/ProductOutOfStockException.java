package oneLvShop.exceptions;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public class ProductOutOfStockException extends Exception {
    public ProductOutOfStockException() {
        super("Sorry! The product is out of stock.");
    }
}
