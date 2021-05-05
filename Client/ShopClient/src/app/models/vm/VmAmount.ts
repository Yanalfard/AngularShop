import { TblColor } from "../dto/TblColor";
import { TblProduct } from "../dto/TblProduct";
import { TblSize } from "../dto/TblSize";

export class VmAmount {
    amountId!: number;
    color!: TblColor;
    size!: TblSize;
    priceBeforeDiscount!: number;
    priceAfterDiscount!: number;
    count!: number;
    product!: TblProduct;
}
