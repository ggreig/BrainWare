import { OrderProduct } from "./order-product";

export class Order {
    orderId = 0;
    companyName = "";
    description = "";
    orderTotal = 0;
    orderProducts: OrderProduct[] = [];
}
