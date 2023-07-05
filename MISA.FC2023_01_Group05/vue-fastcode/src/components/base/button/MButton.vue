<template>
    <button ref="btn" :disabled="disabled" :class="['m-btn', type ? `m-btn-${type}` : '', className]">
        <div v-if="type == 'primary-icon'" class="icon"></div>
        <p>
            {{ text }}
        </p>
    </button>
</template>
<script>
export default {
    name: 'MButton',
    props: ['type', 'disabled', 'text', 'className'],
    methods: {
        focus() {
            this.$refs.btn.focus();
        }
    },
}
</script>
<style scoped>
@import url(./button.css);
</style>