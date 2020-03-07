
#ifndef RL_HAL_EXPORT_H
#define RL_HAL_EXPORT_H

#ifdef RL_HAL_STATIC_DEFINE
#  define RL_HAL_EXPORT
#  define RL_HAL_NO_EXPORT
#else
#  ifndef RL_HAL_EXPORT
#    ifdef hal_EXPORTS
        /* We are building this library */
#      define RL_HAL_EXPORT __attribute__((visibility("default")))
#    else
        /* We are using this library */
#      define RL_HAL_EXPORT __attribute__((visibility("default")))
#    endif
#  endif

#  ifndef RL_HAL_NO_EXPORT
#    define RL_HAL_NO_EXPORT __attribute__((visibility("hidden")))
#  endif
#endif

#ifndef RL_HAL_DEPRECATED
#  define RL_HAL_DEPRECATED __attribute__ ((__deprecated__))
#endif

#ifndef RL_HAL_DEPRECATED_EXPORT
#  define RL_HAL_DEPRECATED_EXPORT RL_HAL_EXPORT RL_HAL_DEPRECATED
#endif

#ifndef RL_HAL_DEPRECATED_NO_EXPORT
#  define RL_HAL_DEPRECATED_NO_EXPORT RL_HAL_NO_EXPORT RL_HAL_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef RL_HAL_NO_DEPRECATED
#    define RL_HAL_NO_DEPRECATED
#  endif
#endif

#endif
