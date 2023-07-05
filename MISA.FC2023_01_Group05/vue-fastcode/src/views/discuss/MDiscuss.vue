<template>
    <div class="discuss">
        <div :class="['icon', ThreadType>=0 ? `icon-${ThreadType}` : '']"></div>
        <div class="discuss-body flex-y space-between gap-16">
            <label>{{ ThreadTitle }}</label>
            <div class="flex gap-32">
                <p>{{ UserName }}</p>
                <p>Đã trả lời {{ AnswerNumber }}</p>
            </div>
        </div>

    </div>
</template>
<script>
export default {
    name: 'm-discuss',
    props: ['ThreadTitle', 'ThreadType', 'UserName', 'AnswerNumber']
}
</script>
<style scoped>
.discuss {
    height: 100px;
    width: 100%;
    border-bottom: 1px solid #bbb;
    display: flex;
    align-items: center;
    gap: 16px;
}

.icon {
    height: 36px;
    width: 36px;
}

label {
    color: var(--color-primary);
    font-weight: 700;

}

p {
    margin: unset;
}

.icon-1 {
    background-image: url('../../assets/icon/question-48.png');
    background-size: contain;
}

.icon-2 {
    background-image: url('../../assets/icon/share-64.png');
    background-size: contain;
}

.icon-3 {
    background-image: url('../../assets/icon/discuss-32.png');
    background-size: contain;
}

.icon-0 {
    background-image: url('../../assets/icon/discuss-32.png');
    background-size: contain;
}
</style>