package oneLvShop.exceptions;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public class ProductHasExpiredException extends Exception {
    public ProductHasExpiredException() {
        super("Sorry! The product has expired.");
    }
}
