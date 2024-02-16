export class Book {
    id!: number;
    title!: string;
    author_id!: number;
    category_id!: number;
    page_number!: number;
    description!: string;
    availability!: number;
    release_date!: string;
    review_id!: number | null;
}
