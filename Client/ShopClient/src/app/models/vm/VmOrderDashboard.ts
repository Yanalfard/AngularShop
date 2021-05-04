import { VmAmount } from "./VmAmount";

export class VmOrderDashboard {
  orderId!: number;
  dateOrdered!: Date | string;
  status!: string;
  priceSum!: number;
  productsAndAmounts!: VmAmount[];
}
