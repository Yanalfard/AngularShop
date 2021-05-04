export class VmBlog {
    blogId!: number;
    title!: string;
    description!: string;
    bodyHtml!: string;
    likeCount!: number;
    viewCount!: number;
    dateCreated!: Date | string;
    keywords!: TblKeyword[];
    relatedBlogs!: VmBlogList[];
    comments!: VmComment[];
    imageUrl!: string;
}