export class TblOrder {
                ordeId!: number;
        discountId!: number | null;
        clientId!: number;
        isPayed!: boolean;
        finalPrice!: number;
        addressId!: number;
        sendPrice!: number | null;
        dateSubmited!: Date | string;
        description!: string;
}