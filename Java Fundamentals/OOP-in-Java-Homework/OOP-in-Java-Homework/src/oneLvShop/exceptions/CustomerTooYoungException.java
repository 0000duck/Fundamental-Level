package oneLvShop.exceptions;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public class CustomerTooYoungException extends Exception {
    public CustomerTooYoungException() {
        super("You are too young to buy this product!");
    }
}
