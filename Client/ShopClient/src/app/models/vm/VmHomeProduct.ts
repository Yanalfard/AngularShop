import { VmAmount } from "./VmAmount";

export class VmHomeProduct {
  productId!: number;
  imageUrl!: string;
  name!: string;
  rating!: number;
  rateCount!: number;
  availableAmount: VmAmount[] = [];
}
