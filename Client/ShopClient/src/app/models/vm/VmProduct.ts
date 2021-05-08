import { TblCatagory } from "../dto/TblCatagory";
import { TblKeyword } from "../dto/TblKeyword";
import { VmAmount } from "./VmAmount";
import { VmComment } from "./VmComment";
import { VmHomeProduct } from "./VmHomeProduct";
import { VmPropertyBig } from "./VmPropertyBig";
import { VmPropertyMini } from "./VmPropertyMini";

export class VmProduct {
  productId!: number;
  name!: string;
  priceBeforeDiscount!: number;
  priceAfterDiscount!: number;
  rating!: number;
  rateCount!: number;
  availableAmount!: VmAmount[];
  shortDescription!: string;
  longDescription!: string;
  miniProperty!: VmPropertyMini[];
  bigProperty!: VmPropertyBig[];
  images!: string[];
  category!: TblCatagory;
  keywords!: TblKeyword[];
  comments!: VmComment[];
  relatedProducts!: VmHomeProduct[];
}
