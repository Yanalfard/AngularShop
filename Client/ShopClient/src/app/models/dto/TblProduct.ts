export class TblProduct {
                productId!: number;
        name!: string;
        mainImage!: string;
        descriptionShortHtml!: string;
        descriptionLongHtml!: string;
        catagoryId!: number | null;
        dateCreated!: Date | string | null;
        searchText!: string;
        brandId!: number;
        isDeleted!: boolean;
}