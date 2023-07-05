<template>
    <div class="page">

        <div class="m-row align-center space-between">
            <h2>
                Thảo Luận/Hỏi Đáp
            </h2>
            <m-button @click="openCreateForm" text="Thêm mới" type="primary-icon" className="btn-add"></m-button>
        </div>
        <div class="page__container">
            <div class="m-row align-center space-between">
                <!-- <div class="m-textfield">
                    <div class="m-input-container">
                        <input type="text" placeholder="">
                        <i class="fas fa-search"></i>
                    </div>
                </div> -->
                <m-textfield></m-textfield>
                <m-button text="" type="secondary" className="reload"></m-button>

            </div>
            <m-discuss v-for="(thread, index) in threads" :key="index" :ThreadTitle="thread.MThreadTitle"
                :ThreadType="thread.MThreadType" :UserName="thread.MUserName" :AnswerNumber="thread.MAnswerNumber"></m-discuss>
            <!-- <m-discuss :ThreadType="'question'" :ThreadTitle="'AAAAA'"></m-discuss> -->
        </div>
    </div>
    <m-form @close-form="onCloseForm" formTitle="Thông tin chủ đề " v-if="form.isShow"></m-form>
</template>
<script>
// import DiscussDetail from './DiscussDetail.vue';
import MDiscuss from './MDiscuss.vue';
import MForm from '../../components/base/form/MForm';
import axios from 'axios';
export default {
    name: "DiscussList",
    components: {
        MDiscuss, MForm
    },
    async created() {
        // fetch('data/threads.json')
        //     .then((response) => response.json())
        //     .then((json) => console.log(json));
        const res = await axios.get('https://localhost:44367/api/v1/Threads');
        console.log(res);
        this.threads = res.data;
    },
    data() {
        return {
            threads: [
                {
                    "MThreadId": 1,
                    "MThreadTitle": "Cần giúp đỡ về việc sử dụng thuộc tính flex?",
                    "MThreadType": 1,
                    "MUserName": "Nguyễn Văn Mạnh",
                    "MAnswerNumber": 100,
                    "MCreatedDate": "",
                    "MThreadContent": "",
                },
                {
                    "MThreadId": 2,
                    "MThreadTitle": "Có bao nhiêu cách để thực hiện layout website?",
                    "MThreadType": 1,
                    "MUserName": "Đỗ Văn Cường",
                    "MAnswerNumber": 8,
                    "MCreatedDate": "",
                    "MThreadContent": "",
                },
                {
                    "MThreadId": 3,
                    "MThreadTitle": "Thảo luận về hiệu năng sử dụng các component có binding 2 chiều với nhiều thông tin.",
                    "MThreadType": 2,
                    "MUserName": "Nguyễn Thị Nga",
                    "MAnswerNumber": 12,
                    "MCreatedDate": "",
                    "MThreadContent": "",
                },
                {
                    "MThreadId": 4,
                    "MThreadTitle": "Chia sẻ việc lập trình đồng bộ trong Javascript, những điều cần lưu ý.",
                    "MThreadType": 3,
                    "MUserName": "Hoàng Ngọc Hân",
                    "MAnswerNumber": 54,
                    "MCreatedDate": "",
                    "MThreadContent": "",
                },
                {
                    "MThreadId": 5,
                    "MThreadTitle": "Cho em hỏi về đồ án tốt nghiệp tại trường ĐH Bách Khoa.",
                    "MThreadType": 1,
                    "MUserName": "Trần Diễm Giang",
                    "MAnswerNumber": 20,
                    "MCreatedDate": "",
                    "MThreadContent": "",
                }
            ],
            form: {
                isShow: false,

            }
        }
    },
    methods: {
        onCloseForm() {
            this.form.isShow = false;
        },
        openCreateForm() {
            this.form.isShow = true;
        }
    },
}
</script>
<style scoped>
.page__container {
    padding: 16px;
}

.thread-list {
    display: flex;
    flex-direction: column;
    margin-top: 10px;
}

.thread__icon {
    width: 40px;
    height: 40px;
    background-size: 40px;
    border-radius: 50%;
    flex: 0 0 40px;
    background-repeat: no-repeat;
    background-position: center;
}

.thread-item {
    display: flex;
    align-items: center;
    justify-content: flex-start;
    column-gap: 10px;
    padding: 10px 0;
}

.thread-item+.thread-item {
    border-top: 1px solid var(--border-color-default);
}

.thread-item__title {
    font-weight: 700;
    color: var(--color-primary);
}


.thread-item__info {
    display: flex;
    align-items: center;
    column-gap: 16px;
    margin-top: 4px;
    font-size: 12px;
}



.m-textfield {
    margin: unset;
}

.reload {
    width: 36px;
    background: url('../../assets/img/Sprites.64af8f61.svg') no-repeat -1090px -82px;
}
</style>