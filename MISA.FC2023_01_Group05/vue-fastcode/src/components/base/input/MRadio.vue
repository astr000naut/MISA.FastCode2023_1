<template>
    <div class="radio-input ">
        <input :id="idProps" type="radio" :value="valueProps" :name="nameProps" />
        <label :for="idProps">{{ label }}</label>
    </div>
</template>

<script>
export default {
    name: "MRadio",
    props: {
        label: {
            type: String
        },
        idProps: {
            type: String
        },
        valueProps: {
            type: Number,
        },
        nameProps: {
            type: String,
        }
    }
}
</script>

<style>
.radio-input {
    margin-right: 24px;
    display: flex;
    align-items: center;
    justify-content: center;
}

.radio-input input {
    margin-right: 3px;
}

.radio-container {
    margin: 16px 0;

}
</style>