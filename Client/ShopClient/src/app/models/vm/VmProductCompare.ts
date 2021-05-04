import { TblColor } from "../dto/TblColor";
import { TblSize } from "../dto/TblSize";
import { VmPropertyBig } from "./VmPropertyBig";

export class VmProductCompare {
        productId!: number;
        imageUrl!: string;
        name!: string;
        rating!: number;
        description!: string;
        colors!: TblColor[];
        sizes!: TblSize[];
        properties!: VmPropertyBig[];
        price!: number;
}
