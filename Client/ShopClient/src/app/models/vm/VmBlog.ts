import { TblKeyword } from "../dto/TblKeyword";
import { VmBlogList } from "./VmBlogList";
import { VmComment } from "./VmComment";

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
