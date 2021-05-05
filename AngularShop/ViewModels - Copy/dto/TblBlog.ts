export class TblBlog {
    blogId!: number;
    mainImage!: string;
    title!: string;
    description!: string;
    bodyHtml!: string;
    likeCount!: number;
    viewCount!: number;
    dateCreated!: Date | string;
}