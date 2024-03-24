import { Product } from "./product";

export class OrderProduct {
    orderId = 0;
    productId = 0;
    product: Product = new Product();
    quantity = 0;
    price = 0;
}
