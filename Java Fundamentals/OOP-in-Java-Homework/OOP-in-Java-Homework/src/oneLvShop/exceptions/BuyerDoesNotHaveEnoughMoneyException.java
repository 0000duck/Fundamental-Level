package oneLvShop.exceptions;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public class BuyerDoesNotHaveEnoughMoneyException extends Exception {
    public BuyerDoesNotHaveEnoughMoneyException() {
        super("You do not have enough money to buy this product!");
    }
}
