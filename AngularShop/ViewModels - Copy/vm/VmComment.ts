export class VmComment {
        commentId!: number;
        body!: string;
        dateCreated!: Date | string;
        ownerName!: string;
        ownerImageUrl!: string;
        subComments!: VmComment[];
}